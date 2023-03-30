using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace email.Controllers;

[ApiController]
[Route("/email")]
public class EmailController : ControllerBase
{
    private readonly ISendGridClient _client;
    private readonly IConfiguration _configuration;

    public EmailController(ISendGridClient client, IConfiguration configuration)
    {
        _client = client;
        _configuration = configuration;
    }

    [HttpGet]
    [Route("send")]
    public async Task<IActionResult> SendPlainTextEmail(string toEmail)
    {
        string fromEmail = _configuration.GetSection("SendGridEmailSettings").GetValue<string>("FromEmail");

        string fromName = _configuration.GetSection("SendGridEmailSettings").GetValue<string>("FromName");


        var message = new SendGridMessage()
        {
            From = new EmailAddress(fromEmail, fromName),
            Subject = "Plain text",
            PlainTextContent = "Hello welcome to Emails with SendGrid"
        };

        message.AddTo(toEmail);

        var response = await _client.SendEmailAsync(message);

        string messages = response.IsSuccessStatusCode ? "Email sent" : "Email sending Failed";
        return Ok(messages);
    }
}
