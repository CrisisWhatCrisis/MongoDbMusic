

call :runProgram "C:\Program Files\MongoDB\Server\3.4\bin\mongod.exe" --config "C:\Program Files\MongoDB\Server\3.4\mongod.config"
call :sleep 1

rem call :runProgram "C:\Program Files\MongoDB\Server\3.4\bin\mongo.exe"
rem call :sleep 1
exit /b


:runProgram
start cmd.exe /k "cd %1 && echo Running %2 && .\%2"
exit /b

:sleep
timeout /t %1 /nobreak > NUL
exit /b


