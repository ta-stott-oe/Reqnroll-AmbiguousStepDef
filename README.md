This is a minimal project to reproduce an issue with Reqnroll.

## Repro steps

1. Install Reqnroll extension for Visual Studio (tested with v.2025.1.256)
2. Open the `.sln` in Visual Studio
3. Build
4. View `Feature1.feature`

### Expected outcome
No errors indicated when editing the `.feature` file

### Actual outcome
Step appears with a red squiggly and the message "Ambiguous steps...". When navigating (e.g. F12) to the two step definitions listed, both references go to the same method. i.e. there is no ambiguity.

![image](https://github.com/user-attachments/assets/371be625-873a-43dd-9405-f58401f4c259)
