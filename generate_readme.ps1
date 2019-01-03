
get-content -encoding UTF8 README_header.MD | set-content -encoding UTF8 README.MD

echo "## Liste des epics`r`n" | `
    Add-Content -encoding UTF8 README.MD

ls .\subject\ | % { $file = $_; echo "* [$($file.basename)](subject/$($file.name))"}| `
    Add-content -encoding UTF8 README.MD

echo "`r`n## Prioritized Backlog`r`n`r`n|Epic|Story|`r`n|-|-|" | `
    Add-content -encoding UTF8 README.MD

ls .\subject\ | `
% { $file = $_; get-content -Encoding UTF8 $file.fullname | `
     %{ if ($_ -match "^## (?<title>.+)$") {echo "|$($file.BaseName)|[$($matches["title"])](subject/$($file)#$($matches["title"].replace(" ", "-")))|"} }}| `
         Add-Content -encoding UTF8 README.MD