PULL BEFORE you do your work.

When you PULL
1) If there are error while pulling (db and db log conflict), check using -git status 
	-Delete the local db and db log then pull

When you PUSH
1) Delete the connection string in readme before you push.
	-Open the app.config file and delete the ??? 
		eg. add name ="myCS" connectionString='???'	

After you PULL
1) To connect database.

	i) Go to the database folder, click MyDB.mdf.
	ii) Copy the full path of the connection string.
	iii) Open the app.config file and paste in the ??? with the path you just copied.
		eg. add name ="myCS" connectionString='???'

2) If there are Error MSB3541	
(Files has invalid value "<<<<<<< HEAD". Illegal characters in path. [In line 5428] of C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets)	
	i) Open the Tuition Centre folder.
	ii) Delete the obj folder.


