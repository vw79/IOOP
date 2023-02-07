To resolve the database directory error.

1) Go to the database folder, click MyDB.mdf.
2) Copy the full path of the connection string.
3) Open the app.config file and replace the ??? with the path you just copied.
	eg. add name ="myCS" connectionString='???'