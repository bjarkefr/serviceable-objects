﻿namespace Serviceable.Objects.Remote.Tests.Classes
{
    using Serviceable.Objects.Tests.Classes;

    public class ReproducibleTestCommand : ReproducibleCommandWithData<ContextForTest, ContextForTest, ReproducibleTestData>
    {
        public ReproducibleTestCommand(ReproducibleTestData testData)
            : base(testData)
        {
            Data.DomainName = "Starting text";
        }

        public override ContextForTest Execute(ContextForTest context)
        {
            context.ContextVariable = Data.ChangeToValue;

            return context;
        }
    }
}
