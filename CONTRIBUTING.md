# Contributing to Bearded.FluentSourceGen

You want to help us improve our little library? ~~That's awesome!~~ You're awesome!

At this time, this library is still under heavy development. That means we are still deciding some major design elements of this library. Before making any contributions, we strongly recommend checking out the [issues](https://github.com/beardgame/fluentsourcegen/issues) page.

## The basics

- **Have a question?** [Open an issue!](https://github.com/beardgame/fluentsourcegen/issues/new/choose)
- **Found a bug?** [Open an issue!](https://github.com/beardgame/fluentsourcegen/issues/new/choose)
- **Would you like to request a feature, change or improvement?** [Open an issue!](https://github.com/beardgame/fluentsourcegen/issues/new/choose)

You could also always check out list of issues and see if there's any discussions you want to share your thoughts on.

## You'd actually like to make changes yourself?

Wow, that's even better!

In principle this as easy as forking the repository, making some changes and [opening a pull request](https://github.com/beardgame/fluentsourcegen/compare). From there, we'll review your PR as soon as we can manage, ask questions or request changes if necessary, and once we're happy merge it into our main branch. It's that easy!

Since the direction of this library is still up in the air, if you are implementing an existing feature, consider checking the approach with us by posting an implementation proposal in the issue. If you are implementing a feature for which there is no thicket yet, create an issue to propose that change and mention that you'd like to implement it yourself. We'll let you know what we think as soon as we can. The main reason we might decline code is if we feel it doesn't fit with the purpose of our libraries, but we're very open to suggestions and good arguments.

You can also browse the existing issues for inspiration. You can pick up anything, but we also have the [`good-first-issue` label](https://github.com/beardgame/fluentsourcegen/issues?q=is%3Aissue+is%3Aopen+label%3A%22good+first+issue%22) to indicate which issues are easy to pick up for someone new to the code base.

When writing code for Bearded.FluentSourceGen, keep the following things in mind:

- We like pull requests to be as small as possible, but as large as necessary, to make them as easy to review as possible
- We like organised, consistent, clean, readable and maintainable code, see what's already there for examples (or submit a change if you think you can improve it!)
- We like modern C# features and type-safety
- We like tests

Also remember to assign yourself to an issue if you start working on it.

### Creating PRs: a summary

Before starting your contribution, first check if there is an issue for the feature you are building. If it is assigned, communicate with the assignee to avoid double work; if not, assign the issue to yourself. Use the issue to describe your intended implementation approach. This can help reduce churn in the code review phase, after you have already spent a lot of time on writing code. If no issue is present, you can create a draft PR from an empty branch (`git commit --allow-empty -m "[description of your feature]"`) instead.

PRs to this library are required to:

- include at least one test that demonstrates the new feature in use through a golden;
- update the unreleased section in the [changelog](CHANGELOG.md).

## General tips and tricks

**Be as clear as you can:** Whether you're opening your own issue or PR, or just commenting on them, take the time to express your ideas as clearly as you can. The clearer your message, the better we will understand you, and the easier it will be for us to help you or to take your thoughts into consideration.

**Don't worry about not knowing or understanding things:** Everyone has questions, gaps in their knowledge, or is unfamilar with certain topics. If you're unsure about anything, just ask! There are no dumb questions.
