# Code Kata Challenges

## Overview
This repository contains a collection of coding kata challenges (from Codewars and LeetCode) implemented in multiple programming languages. It's designed as a learning and practice platform for improving programming skills across different languages.

**Current State:** Fully configured and running in Replit environment with an interactive menu system.

## Recent Changes
- **October 13, 2025**: Initial Replit environment setup
  - Installed .NET 8.0, Node.js 20, and Python 3.11
  - Created unified menu-driven console application (index.js)
  - Configured TypeScript compilation (tsconfig.json)
  - Set up workflow to run the kata runner
  - Updated .gitignore for all languages

## Project Structure

```
.
├── index.js                  # Main menu application (entry point)
├── package.json              # Node.js dependencies
├── tsconfig.json            # TypeScript configuration
├── c-sharp-kata/            # C# kata solutions
│   ├── Program.cs           # C# main entry point
│   ├── Solutions/           # C# solution files
│   └── c-sharp-kata.csproj  # .NET project file
├── javascript-kata/         # JavaScript kata solutions
├── python-kata/             # Python kata solutions (.py and .ipynb)
├── typescript-kata/         # TypeScript kata solutions
└── leetcode/                # LeetCode-specific challenges
    └── python-leetcode/     # Python LeetCode solutions (Jupyter)
```

## Available Kata Solutions

### JavaScript Katas
- Array Helpers
- Good vs Evil
- Hashtag Generator
- IP Address Count
- IP Validator
- Merge Two Sorted Lists
- Pagination Helper
- Two Sum
- Credit Card Validator
- Vowel Code

### Python Katas
- Good vs Evil
- Credit Card Validator
- Vowel Code
- Multiple Jupyter notebook solutions

### C# Katas
- Test - Hello World
- Array Diff
- Codewars Ranking System

### TypeScript Katas
- IP Address Count
- IP Validator
- Pagination Helper

## How to Use

### Running the Interactive Menu
The project automatically starts with an interactive console menu when you click "Run". You can:
1. Browse kata solutions by language
2. Execute JavaScript and Python katas directly
3. Build and view C# solutions
4. View TypeScript kata information

### Running Individual Files

**JavaScript:**
```bash
node javascript-kata/array-helper.js
```

**Python:**
```bash
python python-kata/good-evil.py
```

**C#:**
```bash
cd c-sharp-kata
dotnet build
dotnet run
```

**TypeScript:**
```bash
npm run build:ts
node typescript-kata/dist/ip-count.js
```

## Technologies

- **Languages**: C# (.NET 8.0), JavaScript (Node.js 20), Python 3.11, TypeScript
- **Tools**: npm, dotnet CLI, Python interpreter
- **Notebooks**: Jupyter notebooks for Python solutions

## Development Notes

- The C# `Program.cs` Main method is currently empty. Modify it to call specific solution methods from the Solutions namespace.
- Python notebooks (.ipynb) contain interactive solutions and can be run in Jupyter environments.
- TypeScript files need to be compiled before running (use `npm run build:ts`).
- The interactive menu system (index.js) provides a unified way to explore and run solutions.

## User Preferences
- No specific preferences recorded yet

## Architecture Decisions
- **Multi-language approach**: Maintains separate directories for each language to keep solutions organized
- **Interactive console interface**: Created a Node.js-based menu system for easy navigation
- **Minimal dependencies**: Each language uses its standard tooling without extra frameworks
- **Console-first design**: Optimized for command-line interaction, suitable for Replit's console output
