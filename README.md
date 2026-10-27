# NetSend

A minimal VB.NET Windows Forms frontend for `net send`.

## What it does

Enter a computer name or IP address and a message, then click the button. The
program runs `net send` to deliver the message.

`net send` relies on the Windows Messenger service, which was removed in Windows
Vista, so this only works on older Windows versions.

## Tech

- Visual Basic .NET (Windows Forms)

## Building

Open the `.sln` file in Visual Studio and build it. Windows only.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
