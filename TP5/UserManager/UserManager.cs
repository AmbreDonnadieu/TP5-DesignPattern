using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class UserManager
{
    public static List<User> AllUsers = new List<User>();
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
    }

    public static void UsersFromJson()
    {
        JArray o1 = JArray.Parse(File.ReadAllText(@"users.json"));

        foreach (JToken token in o1)
        {
            User user = new User();
            user.nom = token["nom"].ToString();
            user.prenom = token["prenom"].ToString();
            user.email = token["email"].ToString();
            user.username = token["username"].ToString();

            AllUsers.Add(user);
        }
    }

    public static User FindByUsername(string username2)
    {
        User theUser = new User();
        foreach(User u in AllUsers)
        {
            if(u.username == username2)
            {
                theUser = u;
            }
        }
        return theUser;
    }
}
