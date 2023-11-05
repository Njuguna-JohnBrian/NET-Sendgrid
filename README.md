# SendGrid Email Integration with .NET

This .NET project demonstrates how to use SendGrid to send emails in your application. SendGrid is a cloud-based email delivery service that allows you to send transactional and marketing emails.

## Prerequisites

Before you can use this project, make sure you have the following prerequisites:

- [.NET 7.0](https://dotnet.microsoft.com/download/dotnet/7.0) installed on your system.
- A SendGrid account. If you don't have one, you can sign up for a free SendGrid account at [SendGrid Signup](https://signup.sendgrid.com/).

## Configuration

You will need to configure your SendGrid API key and email settings in the `appsettings.json` file. Here is an example of the `appsettings.json` file:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "SendGridEmailSettings": {
    "ApiKey": "YOUR_SENDGRID_API_KEY",
    "FromEmail": "your.email@example.com",
    "FromName": "Your Name"
  }
}
```

Replace `"YOUR_SENDGRID_API_KEY"` with your SendGrid API key and set the "FromEmail" and "FromName" with your preferred values.

## Project Structure

- **SendGridEmailService.cs**: This class contains the logic to send emails using the SendGrid API. It utilizes the SendGrid C# library to send emails.

- **Controllers/EmailController.cs**: This controller exposes an endpoint for sending emails. You can customize this endpoint as needed for your application.

## Dependencies

This project uses the following NuGet packages, which are defined in the `csproj` file:

- `Microsoft.AspNetCore.OpenApi`: This package provides OpenAPI (Swagger) integration for documenting your API.

- `SendGrid`: This package is the SendGrid C# library for sending emails.

- `SendGrid.Extensions.DependencyInjection`: This package provides integration with the SendGrid API via dependency injection.

- `Swashbuckle.AspNetCore`: This package is used for Swagger documentation of the API.

## Getting Started

To use SendGrid to send emails in your application, follow these steps:

1. Clone or download this project to your local machine.

2. Configure your `appsettings.json` file with your SendGrid API key and email settings as described in the "Configuration" section.

3. Build and run the project using Visual Studio, Visual Studio Code, or the command line.

4. Use the `/api/email/send` endpoint to send emails through SendGrid.

## Example Usage

You can use a tool like [Postman](https://www.postman.com/) or any API client to send POST requests to the `/api/email/send` endpoint with the necessary email details in the request body.

Example POST request body:

```json
{
  "toEmail": "recipient@example.com",
  "subject": "Hello from SendGrid",
  "body": "This is a test email sent from SendGrid!"
}
```

## Contributing

If you'd like to contribute to this project or have any suggestions or improvements, feel free to submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.