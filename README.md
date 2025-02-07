# SecureApi

## Description
This API is designed to provide secure data encryption and decryption services. It utilizes the latest C# technologies and is hosted on AWS Elastic Beanstalk for high availability and performance. The API supports basic cryptographic functions and is ideal for educational or developmental use.

## Features
- **Encryption endpoint:** Encrypts text based on a numeric shift.
- **Decryption endpoint:** Decrypts text by reversing the encryption process.
- **CI/CD pipeline:** Fully automated using GitHub Actions.
- **Hosting:** Deployed on AWS Elastic Beanstalk.

## Getting Started

### Prerequisites
To get started with this project, you will need:
- .NET 8.0 SDK
- An IDE such as Visual Studio or VSCode
- Swagger for API testing
- An AWS account for hosting the API on Elastic Beanstalk

### Installation
Follow these steps to get the API up and running:
1. Clone the SecureApi repository from GitHub.
2. Open the solution file `SecureApi.sln` in Visual Studio or VSCode.
3. Build and run the solution to launch the API locally.
4. Access the Swagger UI to test the API endpoints at `localhost:<port>/swagger`.

### Usage
Use the API through the Swagger interface or by sending HTTP requests:
- **Encrypt**: POST `/api/crypto/encrypt` with JSON payload `{"text": "hello", "shift": 3}`
- **Decrypt**: POST `/api/crypto/decrypt` with JSON payload `{"text": "khoor", "shift": -3}`

### Unit Testing
The project includes unit tests for encryption and decryption functionalities:
- **Encryption Test**: Encrypt "hello" with a shift of 3 should return "khoor".
- **Decryption Test**: Decrypt "khoor" with a shift of -3 should return "hello".

### Deployment
This API is automatically deployed to AWS Elastic Beanstalk via a GitHub Actions workflow upon any pushes to the `main` branch from new branches created on every step. Ensure your AWS credentials are set up correctly in GitHub Secrets.

http://secureapi-env.eba-ynj2kwxt.eu-north-1.elasticbeanstalk.com/ link to AWS
