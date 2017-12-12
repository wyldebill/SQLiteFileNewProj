# SQLiteFileNewProj
android xamarin file new project with sqlite

this is a sample project for using a sqlite database with xamarin.  since the sqlite connection is a platform specific thing, and in 
this case android specific, that code is in the android project.  the .net standard project, what used to be pcl's, get's the connection 
by using the xamarin forms dependency service registered in the android project.

there is no database schema initialization code, there isn't any error handling, and the connection isn't disposed correctly.

but this code will show you how to create a sqlite database, create a table (of the Dog object) and write a dog into that table.

there are probably other issues with the code, but i didn't find clear direction on just how to do this in a file-new project so i did it 
myself.

try it yourself, file-new project will uncover what you think you know, what you know, and what you do not know.
