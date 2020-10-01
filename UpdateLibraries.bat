REM Copy the latest version of the plugin to the tester.
copy "CKSimEngineUnity\CKSimEngineUnity\bin\Debug\CKSimEngineUnity.dll" "CK Sim Engine Tester/Assets/Plugins/"

REM Copy the latest libraries to the tester.
copy "CKSimEngineUnity\packages\AsyncIO.0.1.69\lib\net40\AsyncIO.dll" "CK Sim Engine Tester/Assets/Plugins/"
copy "CKSimEngineUnity\packages\NaCl.Net.0.1.13\lib\net472\NaCl.dll" "CK Sim Engine Tester/Assets/Plugins/"
copy "CKSimEngineUnity\packages\NetMQ.4.0.1.6\lib\net47\NetMQ.dll" "CK Sim Engine Tester/Assets/Plugins/"
copy "CKSimEngineUnity\packages\System.Buffers.4.4.0\lib\netstandard2.0\System.Buffers.dll" "CK Sim Engine Tester/Assets/Plugins/"
copy "CKSimEngineUnity\packages\System.Memory.4.5.3\lib\netstandard2.0\System.Memory.dll" "CK Sim Engine Tester/Assets/Plugins/"
copy "CKSimEngineUnity\packages\System.Numerics.Vectors.4.4.0\lib\net46\System.Numerics.Vectors.dll" "CK Sim Engine Tester/Assets/Plugins/"
copy "CKSimEngineUnity\packages\System.Runtime.CompilerServices.Unsafe.4.5.3\lib\net461\System.Runtime.CompilerServices.Unsafe.dll" "CK Sim Engine Tester/Assets/Plugins/"
copy "CKSimEngineUnity\packages\System.Threading.Tasks.Extensions.4.5.4\lib\net461\System.Threading.Tasks.Extensions.dll" "CK Sim Engine Tester/Assets/Plugins/"
copy "CKSimEngineUnity\packages\System.ValueTuple.4.5.0\lib\net47\System.ValueTuple.dll" "CK Sim Engine Tester/Assets/Plugins/"

REM Pause to dubug.
REM pause