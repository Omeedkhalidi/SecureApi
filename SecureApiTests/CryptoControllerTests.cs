using System;
using Xunit;
using SecureApi.Controllers;  
using Xunit;
using SecureApi.Controllers;  
using Microsoft.AspNetCore.Mvc;

public class CryptoControllerTests
{
    private readonly CryptoController _controller;

    public CryptoControllerTests()
    {
        _controller = new CryptoController();
    }

    [Theory]
    [InlineData("hello", 3, "khoor")]
    [InlineData("hello", -3, "ebiil")]
    public void Encrypt_ReturnsCorrectResult(string input, int shift, string expected)
    {
        var result = _controller.Encrypt(input, shift).Result as OkObjectResult;  
        Assert.NotNull(result);  
        Assert.Equal(expected, result.Value as string);
    }

    [Theory]
    [InlineData("khoor", 3, "hello")]
    [InlineData("ebiil", -3, "hello")]
    public void Decrypt_ReturnsCorrectResult(string input, int shift, string expected)
    {
        var result = _controller.Decrypt(input, shift).Result as OkObjectResult;  
        Assert.NotNull(result); 
        Assert.Equal(expected, result.Value as string); 
    }
}