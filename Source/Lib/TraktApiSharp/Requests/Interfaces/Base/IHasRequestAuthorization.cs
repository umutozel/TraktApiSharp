﻿namespace TraktApiSharp.Requests.Interfaces.Base
{
    using Requests.Base;

    internal interface IHasRequestAuthorization
    {
        AuthorizationRequirement AuthorizationRequirement { get; }
    }
}
