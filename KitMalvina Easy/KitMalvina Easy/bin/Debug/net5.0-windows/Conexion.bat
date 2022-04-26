rasdial EASYVPN/disconnect
rasdial EASYVPN GILBARBARAW10 GILBARBARAW10
for /f "delims=: tokens=2" %%a in ('netsh interface ip show address "EASYVPN" ^| findstr /i "direcci"') do set ip=%%a
set ip=%ip: =%
echo %ip%
Route add 10.30.200.71 mask 255.255.255.255 %ip%
Route add 10.30.200.91 mask 255.255.255.255 %ip%
Route add 10.30.200.74 mask 255.255.255.255 %ip%
pause
