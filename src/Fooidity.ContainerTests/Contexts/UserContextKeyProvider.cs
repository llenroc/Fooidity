﻿namespace Fooidity.ContainerTests.Contexts
{
    public class UserContextKeyProvider :
        ContextKeyProvider<UserContext>
    {
        public string GetKey(UserContext context)
        {
            return context.Name;
        }
    }
}