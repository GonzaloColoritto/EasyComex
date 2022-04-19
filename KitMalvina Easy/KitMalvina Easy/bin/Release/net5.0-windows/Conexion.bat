rasdial EASYVPN /disconnect
rasdial EASYVPN GOZZI GOZZI
for /f "delims=: tokens=2" %%a in ('ipconfig ^| findstr /i "ipv4"') do (set ip=%%a
goto :break
)
:break
set ip=%ip: =%
echo %ip%
Route add 10.30.200.71 mask 255.255.255.255 %ip%
Route add 10.30.200.91 mask 255.255.255.255 %ip%
Route add 10.30.200.74 mask 255.255.255.255 %ip%
