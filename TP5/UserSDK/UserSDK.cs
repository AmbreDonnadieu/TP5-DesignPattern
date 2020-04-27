using System;
using System.Collections.Generic;

public class User
{
    public string nom {get;set;}
    public string prenom {get;set;}
    public string email {get;set;}
    public string username {get;set;}

    public User()
    {
        nom = "nom";
        prenom="prenom";
        email= prenom+"."+nom+"@email.com";
        username="username";
    }


    public static User GetUser(string pseudo, List<User> AllUsers)
    {
        foreach(User u in AllUsers)
        {
            if(u.username == pseudo)
            {
                return u;
            }
        }
        return null;
    }
}
