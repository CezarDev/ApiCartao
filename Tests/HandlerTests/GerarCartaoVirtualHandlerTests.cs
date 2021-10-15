using Domain.Commands.Results;
using Domain.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.HandlerTests;
{
    [TestClass]
public class GerarCartaoVirtualHandlerTests
{
    [TestMethod]
    public void DeveRetornarEmailInvalido()
    {
        var command = new GerarCartaoVirtualCommad();
        command.Email = "cezar.alves.dev@gmail.com";

        var gerarCartaoHandler = new GerarCartaoVirtualHandler();
        var result = gerarCartaoHandler.Handle(command);

        Assert.AreEqual(result, typeof(string));
    }

}
}