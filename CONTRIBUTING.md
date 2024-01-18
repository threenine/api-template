# Contributing to API Template Pack

API Template Pack would sincerely welcome & appreciate any contributions! :heart:


## Asking usage questions

This repository's focus is on the development of [API Template Pack](https://www.apitemplatepack.com/) (i.e. fixing bugs, improving features; see above). 

API Template Pack is maintained and implemented by a really small team, (which should read a team of 1)
our resources to answer usage questions is very limited. However, we will attempt to respond to all questions and would
appreciate if you ask your questions on the [Discussion Hub](https://github.com/threenine/api-template/discussions) 
rather than raising an issue. If then your question will then warrant any further development, or other implementation,
it will then make it on to the [API Template Pack Project Board](https://github.com/orgs/threenine/projects/3) which will
enable you to track the progress.


## Submitting a bug report (as an issue)

If you think you've found a bug, please start by searching [the changelog](https://www.apitemplatepack.com/docs/changelog) and [GitHub issues](https://github.com/threenine/api-template/issues) (both open and closed ones!) to see if the problem has already been addressed or documented in any way.

If you find nothing of relevance, [open a new issue](https://github.com/threenine/api-template/issues/new).


**What to include:** Try to include the following information in it:

 * a brief summary
 * minimal, complete, and verifiable repro code (similar to what you'd have to prepare for a Stack Overflow question; see e.g. [their documentation on "How to create a Minimal, Complete, and Verifiable example"](https://stackoverflow.com/help/mcve)
 * a description of the expected (correct) outcome
 * a description of the actual (incorrect) outcome
 * API Template Pack version used


## Submitting a pull request (PR)

Unless for very simple and straightforward changes, please open an issue first to discuss the PR you're about to submit with the API Template Pack team.


**What to include:** Once you do submit a PR, please include the following:

 * Unit tests whenever you add a bug fix, new feature, or when you change an existing one.

 * All changes relevant to Moq users should be documented in the `CHANGELOG.md`. Please describe your change or bug fix in that file (more specifically under the _Unreleased_ heading at the beginning of it). Phrase the summary in a way that it will be easily understandable and useful to other Moq users.

   ```diff
    # Unreleased
    
    ...
    
    #### Fixed
    
   +* <Short explanation of the bug fix> (@<your username>, #<issue or PR number>)
   ```

   Note the inclusion of your user name and a reference to the relevant PR or issue. The former is included to give you credit for your contribution. The latter allows users to trace the history of a change back to the issue where it was first reported.

When raising a PR, please complete the Template as requested and provide as much detail as possible regarding your change
this will help the reviewers to understand and process you change request.




**When a reviewer requests changes to your PR,** we encourage (but don't require) you to keep your PR tidy using any Git facilities available: You can rewrite your PR branch's history by amending existing commits, rebasing, etc., then force-pushing the changed commits to your PR branch. If you are not familiar enough with Git to do all of this, simply adding more commits to make requested changes is fine. A Moq team member merging your PR may decide to "squash" them into a single commit to keep the repository's history more easily readable.


## Code style rules

**Indentation, line endings, etc.**: The project includes a [`.editorconfig`](https://editorconfig.org/) file. Please make sure your IDE can read this file so that indentation, line endings, etc. is kept consistent across the whole code base. When submitting a PR, try to keep your commit diffs free of whitespace-only changes.


**Copyright notice:** If you add a new file to the solution, please reproduce the short copyright notice found at the beginning of existing files.


**.NET code conventions:** The API Template Pack codebase follows the usual .NET code conventions as documented e.g. in [Framework Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/); so following the existing conventions should be no big issue when adding new code.
