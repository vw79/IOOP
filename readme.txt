1) To resolve the database directory error.

	i) Go to the database folder, click MyDB.mdf.
	ii) Copy the full path of the connection string.
	iii) Open the app.config file and replace the ??? with the path you just copied.
		eg. add name ="myCS" connectionString='???'

2) If there are Error MSB3541	
(Files has invalid value "<<<<<<< HEAD". Illegal characters in path. [In line 5428] of C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets)	
	i) Open the Tuition Centre folder.
	ii) Delete the obj folder.


