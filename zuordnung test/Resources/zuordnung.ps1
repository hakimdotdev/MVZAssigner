$Destination
Get-ChildItem $Source | ForEach-Object {
    $Tail = ($_.BaseName -split '_')[-2]
    $Filter = "*_{0}" -f $Tail
    $DestDir = Get-ChildItem $Destination -Filter $Filter -Directory | Select-Object -ExpandProperty FullName -First 1
    if ($DestDir) {
        Copy-Item $_.FullName $DestDir -Force
    } else {
        "No Directory was found that matched the Filter {0} in Directory {1}" -f $Filter, $Destination | Write-Host
    }
}

