:: Copy the C++ DLL.
copy "CKSimEnginePlugin\CKSimEngineUnityPlugin\lib\Debug\x64\CKSimEngineUnityPlugin.dll" "CKSimEngineTester/Assets/Plugins/"

:: Copy the DLL dependencies.
copy "CKSimEnginePlugin\CKlibzmq\bin\libzmq-v142-mt-4_3_3.dll" "CKSimEngineTester/Assets/Plugins/"

:: Pause to debug.
pause