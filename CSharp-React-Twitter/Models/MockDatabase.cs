﻿using System;
using System.Collections.Generic;

namespace CSharpReactTwitter.Models {
  public class MockDatabase : DB {
    private List<User> _users ;
    private List<Tweet> _tweets;

    public MockDatabase() {
      _users = new List<User>();
      _tweets = new List<Tweet>();

      _users.Add(new User { username = "kevin", id = 0, name = "Kevin Doveton" });
      _users.Add(new User { username = "amelia", id = 1, name = "Amelia Parsons" });
      _users.Add(new User { username = "mark", id = 2, name = "MarkyD" });
      _users.Add(new User { username = "bazz223", id = 3, name = "Trent Barry" });
      _users.Add(new User { username = "appel", id = 4, name = "Appel Corporation" });

      _tweets.Add(new Tweet {
        user = GetUserById(0),
        dateTime = DateTime.Now,
        text = "hello, world!",
        id = 0
      });
      _tweets.Add(new Tweet {
        user = GetUserById(1),
        dateTime = DateTime.Parse("05/02/2018 15:50:31"),
        text = "hello, world!",
        id = 1
      });
      _tweets.Add(new Tweet {
        user = GetUserById(3),
        dateTime = DateTime.Parse("05/02/2018 5:50:31"),
        text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
          "Morbi sed elementum erat, eget placerat odio. Donec viverra " +
          "placerat placerat. A Do",
        id = 2
      });
      _tweets.Add(new Tweet {
        user = GetUserById(2),
        dateTime = DateTime.Parse("04/02/2018 18:50:31"),
        text = "Quisque tristique a odio at maximus.Ut ultricies mattis " +
          "justo, id commodo ante dictum vitae",
        id = 3
      });
      _tweets.Add(new Tweet {
        user = GetUserById(4),
        dateTime = DateTime.Parse("02/02/2018 18:20:31"),
        text = "We have been defeated!",
        id = 4
      });
    }

    public override User GetUserById(int id) {
      return _users.Find(i => i.id == id);
    }

    public override List<Tweet> GetNewsfeedForUser(int id) {
      return _tweets;
    }

    public override Tweet GetTweetById(int id) {
      return _tweets.Find(item => item.id == id);
    }

  }
}
