﻿namespace Adapter.Sites
{
    public class Facebook: IFaceBook
    {
        private readonly string _name;
        private readonly int _friendsCount;
        private readonly int _age;

        public Facebook(string name, int friendsCount, int age)
        {
            _name = name;
            _friendsCount = friendsCount;
            _age = age;
        }

        public string Name
        {
            get { return _name; }
        }

        public int FriendsCount
        {
            get { return _friendsCount; }
        }

        public int Age
        {
            get { return _age; }
        }
    }
}
