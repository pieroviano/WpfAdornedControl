IF NOT DEFINED Configuration SET Configuration=Release
MSBuild.exe WpfAdornedControl.sln -t:clean
MSBuild.exe WpfAdornedControl.sln -t:restore -p:RestorePackagesConfig=true
MSBuild.exe WpfAdornedControl.sln -m /property:Configuration=%Configuration%
git add -A
git commit -a --allow-empty-message -m ''
git push