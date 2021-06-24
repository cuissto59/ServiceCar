
English:

Firstly execute file db/servicecar.sql in your RDBMS Mysql(the script is compatible unfortunatly just with Mysql).

secondly go change files :

        appsettings.json line 12 with the informations about db server and your (servicecar);
        Models/servicecarContext.cs line 37 with the informations about db server and your (servicecar);

and lastly users are :

    Admin :

            login : admin password : admin ;
    
    Conductors :

            login : conductor1 password : conductor1 ;
            login : conductor2 password : conductor2 ;

And Enjoy :)

Francais:

Premièrement veuillez executer le fichier db/servicecar.sql dans votre RDBMS Mysql .

Deuxièmement veuillez changer le fichier 
            appsettings.json line 12 avec vos informations sur la base de donnée;
            Models/servicecarContext.cs line 37 avec vos informations sur la base de donnée;

et dernièrement l'admin c'est : 
        login:admin password:admin

les conducteurs sont :
        
        login: conductor1 password: conductor1
        
        login: conductor2 password: conductor2
