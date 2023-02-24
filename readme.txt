1) Delete the connection string in readme before you push.
	
	i) Open the app.config file and delete the ??? 
		eg. add name ="myCS" connectionString='???'	

2) To connect database.

	i) Go to the database folder, click MyDB.mdf.
	ii) Copy the full path of the connection string.
	iii) Open the app.config file and paste in the ??? with the path you just copied.
		eg. add name ="myCS" connectionString='???'

2) If there are Error MSB3541	
(Files has invalid value "<<<<<<< HEAD". Illegal characters in path. [In line 5428] of C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets)	
	i) Open the Tuition Centre folder.
	ii) Delete the obj folder.


