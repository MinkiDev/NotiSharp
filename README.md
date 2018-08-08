# ![Logo](res/NotiSharp_Logo.png) NotiSharp
Customized notification service library for Windows.

[![NuGet version (NotiSharp)](https://img.shields.io/nuget/v/NotiSharp.svg)](https://www.nuget.org/packages/NotiSharp)

## Usage examples

#### Create a popup form instance
```csharp
NotiSharp.Popup pup = new NotiSharp.Popup();
```

#### Set content text for notification
```csharp
pup.SetText("This is an example content for NotiSharp");
```

#### Set an icon for notification (Bitmap)
```csharp
pup.SetIcon(new Bitmap(@"C:/NotiSharp.jpg"));
```

#### Change the size of popup window
```csharp
pup.SetSize(new Size(600, 400)); // not working in current version (layout problem)
```

#### Show popup window
```csharp
pup.Show();
```
