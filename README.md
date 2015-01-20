# Slash

This is a self hosted [Nancy](http://nancyfx.org) application that will listen on `http://localhost:1234` and accept a `POST` from Stash via a [Webhook](https://confluence.atlassian.com/display/STASH/POST+service+webhook+for+Stash) which will then transform it into a message suitable for Slack and post it to the room setup on your Slack incoming hook
