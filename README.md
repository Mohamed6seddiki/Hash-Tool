# Hash Tool 🔐

A modern, cyberpunk-themed hash generation utility built with .NET Framework, supporting multiple cryptographic hash algorithms.

## Features ✨

- **🔧 Multiple Hash Algorithms**: Support for various hashing algorithms including:
  - MD2
  - MD5
  - RIPEMD-160
  - SHA-1
  - SHA-2 (224, 256, 384, 512 bits)
  - SHA-3 (224, 256, 384, 512 bits)
  - WHIRLPOOL

-  User-Friendly Interface**: Clean, cyberpunk-themed Windows Forms GUI with real-time hash generation
-  Plain Text Input**: Simple text input field for easy hash generation
-  Multiple Output Formats**: Generate hashes in various formats simultaneously
-  Secure Processing**: All hashing is performed locally for security
-  Windows Integration**: Professional Windows installer with system integration

## Installation 💿

### System Requirements 📋

-  Operating System**: Windows 7 or higher (Windows 10/11 recommended)
-  .NET Framework**: 4.7.2 or higher (automatically installed if missing)
-  Memory**: Minimum 512 MB RAM
-  Disk Space**: 50 MB free space
-  Architecture**: x86 or x64

### Method 1: Windows Installer (Recommended) 🚀

**Option A: MSI Installer (Professional Installation) 📦**

1. Download `Setup1.msi` (1,568 KB) from the releases
2. Double-click the MSI file to launch the installer
3. Follow the installation wizard:
   -  Welcome Screen**: Click "Next" to begin
   -  Installation Folder**: Choose destination (default: `C:\Program Files (x86)\Default Company Name\Setup1\`)
   -  User Scope**: Select "Just me" or "Everyone"
   -  Confirm Installation**: Review settings and click "Next"
   -  Completion**: Click "Close" when finished

**Option B: Executable Installer (Quick Installation) ⚡**
1. Download `setup.exe` (537 KB) from the releases
2. Run the installer (may require administrator privileges)
3. Follow the installation prompts

**Option c:  Download via  from the link  🔗**
1. Enter the link and download the zip file  [here](https://limewire.com/d/dpqjN#NBjTFFviqI)
2. Unzip and enter `\Hash tool\Setup\Debug`
3. Click on `setup.exe`
### Method 2: Portable Version 📱

1. Download the release build
2. Extract `HashTool.exe` to your preferred location
3. Run directly without installation
4. No registry modifications or system integration

### Post-Installation 🎯

After successful installation:
-  Application available in Start Menu under "Setup1" or "Hash Tool"
-  Desktop shortcut created (if selected during installation)
-  Registered in Windows "Add or Remove Programs"
-  Associated with .NET Framework runtime

## Usage 🚀

1.  Launch Hash Tool from Start Menu or desktop shortcut
2.  Enter your plain text in the "enter your text" field
3.  Hash values are generated automatically in real-time
4.  View results for all supported algorithms in the output fields
5.  Click "Destroy All" to clear all input and output fields

## Development 👨‍💻

### Building from Source 🔨

**Prerequisites:** 📋
- 🔧 Visual Studio 2019 or higher (Community, Professional, or Enterprise)
- ⚙️ .NET Framework 4.7.2 SDK or higher
- 🖥️ Windows 10 SDK (latest version recommended)

**Build Steps:** 🛠️
1. Clone the repository:
```bash
git clone https://github.com/Mohamed6seddiki/Hash-Tool.git
```

2. 📂 Open `HashTool.sln` in Visual Studio

3.  Restore NuGet packages (if any):
   - Right-click solution → "Restore NuGet Packages"

4.  Build the solution:
   - ** Debug**: Build → Build Solution (F7)
   - ** Release**: Set to Release configuration, then build

5.  Create installer (optional):
   - Right-click `Setup1.vdproj` → Build

### Architecture 🏗️

The application follows a clean Windows Forms architecture:

- ** Presentation Layer**: Windows Forms UI (`Form1.cs`)
- ** Business Logic**: Hash algorithm implementations (`HashAlgorithms.cs`)
- ** Data Layer**: In-memory processing (no external dependencies)

## Supported Hash Algorithms 🧮

| Algorithm | Output Length | Security Status | Use Case |
|-----------|---------------|-----------------|----------|
| MD2 | 128 bits | ❌ Broken | Legacy support only |
| MD5 | 128 bits | ❌ Broken | Checksums (not secure) |
| RIPEMD-160 | 160 bits | ⚠️ Deprecated | Alternative to SHA-1 |
| SHA-1 | 160 bits | ❌ Broken | Legacy (deprecated) |
| SHA-2 224 | 224 bits | ✅ Secure | Modern hashing |
| SHA-2 256 | 256 bits | ✅ Secure | Most common secure hash |
| SHA-2 384 | 384 bits | ✅ Secure | Higher security |
| SHA-2 512 | 512 bits | ✅ Secure | Maximum security |
| SHA-3 224 | 224 bits | ✅ Secure | Next-gen hashing |
| SHA-3 256 | 256 bits | ✅ Secure | Next-gen hashing |
| SHA-3 384 | 384 bits | ✅ Secure | Next-gen hashing |
| SHA-3 512 | 512 bits | ✅ Secure | Next-gen hashing |
| WHIRLPOOL | 512 bits | ✅ Secure | Alternative secure hash |

## Security Notes 🔐

⚠️ **Important Security Considerations:**

- ** Broken Algorithms**: MD2, MD5, SHA-1 are cryptographically broken and should not be used for security purposes
- ** Secure Algorithms**: SHA-2 and SHA-3 families are currently considered secure
- ** Local Processing**: All hashing is performed locally - no data is transmitted over networks
- ** Memory Management**: Sensitive data is cleared from memory after processing

## Troubleshooting 🔧

### Common Issues 🚨

" .NET Framework not found"**
-  Download and install .NET Framework 4.7.2 or higher from Microsoft
-  Use the MSI installer which automatically handles dependencies

" Application won't start"**
-  Ensure you have administrator privileges if needed
-  Check Windows Event Viewer for detailed error messages
-  Verify .NET Framework version compatibility

"❓ Hash results appear incorrect"**
-  Verify input text encoding (application uses UTF-8)
-  Compare results with online hash calculators for verification
- 👁 Check for hidden characters in input text

## Contributing 🤝

Contributions are welcome! Please feel free to submit a Pull Request.

### Development Workflow 🔄
1.  Fork the project
2.  Create your feature branch (`git checkout -b feature/AmazingFeature`)
3.  Make changes in Visual Studio
4.  Build and test thoroughly
5.  Commit your changes (`git commit -m 'Add some AmazingFeature'`)
6.  Push to the branch (`git push origin feature/AmazingFeature`)
7.  Open a Pull Request

### Code Standards 📜
-  Follow C# coding conventions
-  Use meaningful variable and method names
-  Add XML documentation for public methods
-  Include unit tests for new functionality

## Uninstallation 🗑️

**Standard Uninstall:** 🛠️
1.  Open Windows Settings → Apps & Features
2.  Search for "Setup1" or "Hash Tool"
3.  Click "Uninstall" and follow prompts

Alternative Method:** 🔄
-  Use "Add or Remove Programs" in Control Panel
-  Or run uninstaller from installation directory

## License 📄

This project is open-source and free to use for educational or non-commercial purposes.

## Author 👨‍💻

**Mohamed Seddiki**
- 🐙 GitHub: [@Mohamed6seddiki](https://github.com/Mohamed6seddiki)

## Acknowledgments 🙏

-  Built with .NET Framework and Windows Forms
-  Cryptographic implementations based on .NET System.Security.Cryptography
-  UI design inspired by cyberpunk aesthetics
-  Thanks to the cybersecurity community for algorithm recommendations

---

*Made with ❤️ for the cybersecurity community using .NET Framework* 🚀
