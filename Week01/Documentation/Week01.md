# Week 01 - Environment Setup, C# Basics & Git Fundamentals

## Overview

This week focused on setting up the development environment, creating the first C# console application, configuring SQL Server LocalDB, and learning the fundamentals of Git and GitHub.

---

# Objectives

- Set up the .NET development environment.
- Verify .NET SDK installation.
- Create and execute a C# Console Application.
- Configure SQL Server LocalDB.
- Create a GitHub repository.
- Learn the basic Git workflow using feature branches.

---

# Tasks Completed

| Task | Status |
|------|--------|
| Installed .NET SDK | ✅ Completed |
| Verified installation using `dotnet --info` | ✅ Completed |
| Created Console Application | ✅ Completed |
| Executed Hello Cohort program | ✅ Completed |
| Created SandboxDb | ✅ Completed |
| Created GitHub Repository | ✅ Completed |
| Created Feature Branch | ✅ Completed |
| Organized Week01 repository structure | ✅ Completed |

---

# Project Structure

```
Week01
│
├── Documentation
├── Project
│   └── Week01
│       ├── Program.cs
│       ├── Week01.csproj
│       └── Week01.slnx
│
└── Screenshots
```

---

# Commands Used

## .NET

```bash
dotnet --info
dotnet new console -n Week01
```

## Git

```bash
git branch

git checkout -b feature/day01-update

git status

git status --ignored

git status -u
```

---

# Concepts Learned

## .NET

- Difference between .NET SDK and Runtime.
- Purpose of a Console Application.
- Difference between Solution (.sln/.slnx) and Project (.csproj).

## SQL Server

- Connected to SQL Server LocalDB.
- Created SandboxDb.

## Git

- Repository
- Branch
- Working Directory
- Untracked Files
- Ignored Files
- .gitignore
- Feature Branch Workflow

---

# Screenshots

- 01-dotnet-info.png
- 02-visual-studio-project.png
- 03-console-output.png
- 04-sandboxdb.png
- 05-github-repository.png
- 06-feature-branch.png

---

# Challenges Faced

- Faced authentication issues while cloning a private GitHub repository changed it to public and need to learn about the private access.
- Understood the difference between public and private repositories.

---

# Key Learnings

- A Solution (.sln/.slnx) can contain one or more projects.
- A Project (.csproj) represents a single C# project.
- Git does not track empty folders.
- Git ignores generated folders such as bin and obj through .gitignore.
- The git status command shows the current state of the repository.
- A feature branch allows development without affecting the main branch.

---

# Next Steps

- Learn Git staging, commit, push, pull request, and merge.
- Continue with Week 2 tasks.