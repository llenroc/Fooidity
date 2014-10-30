﻿namespace Fooidity.Management.Contracts
{
    using System;


    public interface CodeFeatureDisabled
    {
        Guid CommandId { get; }

        DateTime Timestamp { get; }

        Uri CodeFeatureId { get; }

        Guid OriginatingCommandId { get; }
    }
}