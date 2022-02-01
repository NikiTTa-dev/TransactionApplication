using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Splitter
{
    static class Splitter
    {
        static public Dictionary<string, User> UserSplitter(params string[] userLines)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            foreach (string line in userLines)
            {
                var userSplit = line.Split(' ');
                var birthDay = new DateTime(
                    Int32.Parse(userSplit[3]),
                    Int32.Parse(userSplit[4]),
                    Int32.Parse(userSplit[5])
                    );
                var user = new User(userSplit[0],
                    userSplit[1],
                    userSplit[2],
                    birthDay);
                users.Add(userSplit[0], user);
            }

            return users;
        }

        static public Dictionary<string, Transaction> TransSplitter(params string[] transLines)
        {
            Dictionary<string, Transaction> trans = new Dictionary<string, Transaction>();
            foreach (string line in transLines)
            {
                var transSplit = line.Split(' ');
                var transTime = new DateTime(
                    Int32.Parse(transSplit[3]),
                    Int32.Parse(transSplit[4]),
                    Int32.Parse(transSplit[5]),
                    Int32.Parse(transSplit[6]),
                    Int32.Parse(transSplit[7]),
                    Int32.Parse(transSplit[7])
                    );
                var transaction = new Transaction(transSplit[0],
                    transSplit[1],
                    Double.Parse(transSplit[2]),
                    transTime);
                trans.Add(transSplit[0], transaction);
            }

            return trans;
        }
    }
}
