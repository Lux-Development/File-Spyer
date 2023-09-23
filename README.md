![scanner](https://github.com/joelb-services/File-Spyer/assets/144958989/efaa2668-ff32-4916-b6d6-16e624ecad15)

# What is a file scanner?
File scanners search through your PC, for this its simply just your whole C:\ drive. However you can simply change the code for this to be changed, see more information below on how to do this.

# What does it capture?
- All files deleted
- All files renamed
- All files created

# Why would I need this?
This is great to capture malware, or hidden files on your computer, to see what files are being moved around, and created. It is also great to find location paths of certain applications, such as when you open a file normally a file in that location will be created or edited.

# Changing the scan path?
```csharp
var watcher = new FileSystemWatcher(@"C:\");
```
- Navigate to line: 15
- You will see the above code, change the C:\ to your desired drive/certain path.

### Disclaimer: ⚠️ This was made for educational purposes only, and is not to be directed any way to hurt or damage any company.
