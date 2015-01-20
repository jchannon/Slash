namespace StashCity
{
    public class StashPayload
    {
        public Repository repository { get; set; }
        public Refchange[] refChanges { get; set; }
        public Changesets changesets { get; set; }
    }

    public class Repository
    {
        public string slug { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string scmId { get; set; }
        public string state { get; set; }
        public string statusMessage { get; set; }
        public bool forkable { get; set; }
        public Project project { get; set; }
        public bool @public { get; set; }
    }

    public class Project
    {
        public string key { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public bool @public { get; set; }
        public string type { get; set; }
        public bool isPersonal { get; set; }
    }

    public class Changesets
    {
        public int size { get; set; }
        public int limit { get; set; }
        public bool isLastPage { get; set; }
        public CommitInfo[] values { get; set; }
        public int start { get; set; }
        public object filter { get; set; }
    }

    public class CommitInfo
    {
        public Fromcommit fromCommit { get; set; }
        public Tocommit toCommit { get; set; }
        public Changes changes { get; set; }
        public Link link { get; set; }
    }

    public class Fromcommit
    {
        public string id { get; set; }
        public string displayId { get; set; }
    }

    public class Tocommit
    {
        public string id { get; set; }
        public string displayId { get; set; }
        public Author author { get; set; }
        public long authorTimestamp { get; set; }
        public string message { get; set; }
        public Parent[] parents { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
        public string emailAddress { get; set; }
    }

    public class Parent
    {
        public string id { get; set; }
        public string displayId { get; set; }
    }

    public class Changes
    {
        public int size { get; set; }
        public int limit { get; set; }
        public bool isLastPage { get; set; }
        public FileInformation[] values { get; set; }
        public int start { get; set; }
        public object filter { get; set; }
    }

    public class FileInformation
    {
        public string contentId { get; set; }
        public Path path { get; set; }
        public bool executable { get; set; }
        public int percentUnchanged { get; set; }
        public string type { get; set; }
        public string nodeType { get; set; }
        public bool srcExecutable { get; set; }
        public Link link { get; set; }
    }

    public class Path
    {
        public string[] components { get; set; }
        public string parent { get; set; }
        public string name { get; set; }
        public string extension { get; set; }
        public string toString { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string rel { get; set; }
    }


    public class Refchange
    {
        public string refId { get; set; }
        public string fromHash { get; set; }
        public string toHash { get; set; }
        public string type { get; set; }
    }
}
