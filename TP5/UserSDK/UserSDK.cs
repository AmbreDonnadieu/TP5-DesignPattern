using System;

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
    /*public static User GetUser(string pseudo)
    {
        User u = new User();
        if(this.username ==pseudo){
            u.nom = User.nom;
        }
        return ;
    }*/
}
