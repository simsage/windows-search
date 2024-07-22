; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "SimSage Search"
#define MyAppVersion "1.0"
#define MyAppPublisher "SimSage (UK) Ltd."
#define MyAppURL "https://simsage.ai/"
#define MyAppExeName "SimSageSearch.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{7E7CB346-6776-4C60-B5FB-6BA82381C2F5}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
; "ArchitecturesAllowed=x64compatible" specifies that Setup cannot run
; on anything but x64 and Windows 11 on Arm.
ArchitecturesAllowed=x64compatible
; "ArchitecturesInstallIn64BitMode=x64compatible" requests that the
; install be done in "64-bit mode" on x64 or Windows 11 on Arm,
; meaning it should use the native 64-bit Program Files directory and
; the 64-bit view of the registry.
ArchitecturesInstallIn64BitMode=x64compatible
DisableProgramGroupPage=yes
LicenseFile=C:\Users\peter\dev\windows-search\LICENSE
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=C:\Users\peter\dev\windows-search\installer-output
OutputBaseFilename=simsage-setup
SetupIconFile=C:\Users\peter\dev\windows-search\Non-Code\Icon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\peter\dev\windows-search\bin\Release\net8.0-windows\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\peter\dev\windows-search\bin\Release\net8.0-windows\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
;Registry data from file setup-registry-key.reg
Root: HKCU; Subkey: "SimSageSearch"; Flags: uninsdeletekey; Check: not IsAdminInstallMode
Root: HKCU; Subkey: "SimSageSearch"; ValueType: string; ValueName: "URL"; ValueData: "test.simsage.ai"; Flags: uninsdeletevalue; Check: not IsAdminInstallMode
;End of registry data from file setup-registry-key.reg

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

