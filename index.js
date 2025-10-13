import { createInterface } from 'readline';
import { spawn } from 'child_process';
import { fileURLToPath } from 'url';
import { dirname, join } from 'path';

const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);

const rl = createInterface({
  input: process.stdin,
  output: process.stdout
});

function question(query) {
  return new Promise(resolve => rl.question(query, resolve));
}

function runCommand(command, args, cwd = __dirname) {
  return new Promise((resolve, reject) => {
    const proc = spawn(command, args, {
      cwd,
      stdio: 'inherit',
      shell: true
    });

    proc.on('close', (code) => {
      if (code !== 0) {
        reject(new Error(`Command failed with code ${code}`));
      } else {
        resolve();
      }
    });

    proc.on('error', reject);
  });
}

const katas = {
  javascript: [
    { name: 'Array Helpers', file: 'array-helper.js' },
    { name: 'Good vs Evil', file: 'good-evil.js' },
    { name: 'Hashtag Generator', file: 'hash-tag-generator.js' },
    { name: 'IP Address Count', file: 'ip-count.js' },
    { name: 'IP Validator', file: 'ip-validator.js' },
    { name: 'Merge Two Sorted Lists', file: 'merge-two-lists.js' },
    { name: 'Pagination Helper', file: 'pagination-helper.js' },
    { name: 'Two Sum', file: 'two-sum.js' },
    { name: 'Credit Card Validator', file: 'validate-card.js' },
    { name: 'Vowel Code', file: 'vowel-code.js' }
  ],
  python: [
    { name: 'Good vs Evil', file: 'good-evil.py' },
    { name: 'Credit Card Validator', file: 'validate-card.py' },
    { name: 'Vowel Code', file: 'vowel-code.py' }
  ],
  csharp: [
    { name: 'Test - Hello World', method: 'Test.HelloWorld()' },
    { name: 'Array Diff', method: 'ArrayDiff.performDiff()' },
    { name: 'Codewars Ranking System', method: 'KataUser' }
  ]
};

function displayMenu() {
  console.clear();
  console.log('╔════════════════════════════════════════╗');
  console.log('║     CODE KATA CHALLENGES MENU          ║');
  console.log('╔════════════════════════════════════════╗');
  console.log('║                                        ║');
  console.log('║  1. JavaScript Katas                   ║');
  console.log('║  2. Python Katas                       ║');
  console.log('║  3. C# Katas                           ║');
  console.log('║  4. View All TypeScript Katas          ║');
  console.log('║  5. Exit                               ║');
  console.log('║                                        ║');
  console.log('╚════════════════════════════════════════╝');
  console.log('');
}

function displayKataList(language, kataList) {
  console.clear();
  console.log(`\n${language.toUpperCase()} KATAS:\n`);
  kataList.forEach((kata, index) => {
    console.log(`  ${index + 1}. ${kata.name}`);
  });
  console.log(`  ${kataList.length + 1}. Back to Main Menu\n`);
}

async function runJavaScriptKata(kata) {
  console.log(`\n▶ Running: ${kata.name}\n`);
  try {
    await runCommand('node', [kata.file], join(__dirname, 'javascript-kata'));
    console.log('\n✅ Execution completed!');
  } catch (error) {
    console.error('❌ Error:', error.message);
  }
}

async function runPythonKata(kata) {
  console.log(`\n▶ Running: ${kata.name}\n`);
  try {
    await runCommand('python', [kata.file], join(__dirname, 'python-kata'));
    console.log('\n✅ Execution completed!');
  } catch (error) {
    console.error('❌ Error:', error.message);
  }
}

async function runCSharpKata() {
  console.log(`\n▶ Running C# Kata Project\n`);
  console.log('Note: The C# Program.cs Main method is currently empty.');
  console.log('You can modify it to call any of the solution methods:\n');
  katas.csharp.forEach(kata => {
    console.log(`  - ${kata.name}: c_sharp_kata.Solutions.${kata.method}`);
  });
  console.log('\nRunning dotnet build...\n');
  try {
    await runCommand('dotnet', ['build'], join(__dirname, 'c-sharp-kata'));
    console.log('\n✅ Build completed successfully!');
  } catch (error) {
    console.error('❌ Error:', error.message);
  }
}

async function viewTypeScriptKatas() {
  console.clear();
  console.log('\nTYPESCRIPT KATAS:\n');
  console.log('  1. IP Address Count (ip-count.ts)');
  console.log('  2. IP Validator (ip-validator.ts)');
  console.log('  3. Pagination Helper (pagination-helper.ts)\n');
  console.log('Note: To run TypeScript katas:');
  console.log('  1. Compile: npm run build:ts');
  console.log('  2. Run the compiled JS files from typescript-kata/dist/\n');
  await question('Press Enter to continue...');
}

async function handleLanguageMenu(language, kataList, runFunction) {
  while (true) {
    displayKataList(language, kataList);
    const choice = await question('Select a kata (number): ');
    const index = parseInt(choice) - 1;

    if (index === kataList.length) {
      break;
    }

    if (index >= 0 && index < kataList.length) {
      await runFunction(kataList[index]);
      await question('\nPress Enter to continue...');
    } else {
      console.log('❌ Invalid choice!');
      await question('Press Enter to continue...');
    }
  }
}

async function main() {
  console.log('Welcome to Code Kata Challenges!\n');

  while (true) {
    displayMenu();
    const choice = await question('Enter your choice (1-5): ');

    switch (choice) {
      case '1':
        await handleLanguageMenu('JavaScript', katas.javascript, runJavaScriptKata);
        break;
      case '2':
        await handleLanguageMenu('Python', katas.python, runPythonKata);
        break;
      case '3':
        await runCSharpKata();
        await question('\nPress Enter to continue...');
        break;
      case '4':
        await viewTypeScriptKatas();
        break;
      case '5':
        console.log('\n👋 Goodbye! Happy coding!\n');
        rl.close();
        process.exit(0);
      default:
        console.log('❌ Invalid choice! Please select 1-5.');
        await question('Press Enter to continue...');
    }
  }
}

main().catch(error => {
  console.error('Fatal error:', error);
  rl.close();
  process.exit(1);
});
