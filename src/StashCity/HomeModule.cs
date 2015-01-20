namespace StashCity
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;
    using Slack.Webhooks;
    using System.Linq;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Post["/stash"] = _ =>
            {
                try
                {
                    var model = this.Bind<StashPayload>();

                    var slackClient = new SlackClient("https://hooks.slack.com/services/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");

                    var success = slackClient.Post(new SlackMessage
                    {
                        Text = model.repository.project.name + " was pushed to with " + model.changesets.size +
                            " commits from " + string.Join(",",
                                model.changesets.values.Select(x => x.toCommit.author.name).Distinct())
                    });

                    if (!success)
                    {
                        return Response.AsText("Oops").WithStatusCode(500);
                    }

                    return Response.AsText("Success").WithStatusCode(200);
                }
                catch (Exception ex)
                {

                    return Response.AsText(ex.Message).WithStatusCode(500);
                }
            };
        }
    }
}
