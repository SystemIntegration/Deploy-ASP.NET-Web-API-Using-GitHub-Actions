# Deploying ASP.NET Core Web API to AWS Elastic Beanstalk with GitHub Actions

## Prerequisites
- AWS Account – Free Tier is enough
- Visual Studio or your favorite IDE
- .NET 6.0+ SDK installed on your machine
- GitHub Account

## AWS Elastic Beanstalk Setup
1. Log into your AWS account and navigate to AWS Elastic Beanstalk.
2. Click on "Create Application" and provide a name for your web application.
3. Select the platform and configuration (e.g., .NET Core on Linux).
4. Wait for the provisioning process to complete, obtaining a URL for accessing your ASP.NET Core Web API.

## GitHub Action Workflow
1. Create a GitHub Action workflow by defining a YAML file in your repository.
2. Configure the workflow to trigger on pushes to the main branch.
3. Specify jobs for building, testing, packaging, and deploying the application.
4. Utilize GitHub Secrets to securely manage sensitive information such as AWS credentials and region.
5. Leverage GitHub Actions to automate the entire CI/CD pipeline.

## Deployment Steps in GitHub Action Workflow
1. Checkout the source code from the repository.
2. Set up the .NET environment using the specified version.
3. Run unit tests, publish the application, and generate a deployment package.
4. Upload the deployment package as a GitHub artifact.
5. Output environment variables for debugging purposes.
6. Install the AWS CLI in the GitHub Actions environment.
7. Upload the deployment package to an S3 bucket.
8. Deploy the application to AWS Elastic Beanstalk by creating a new application version and updating the environment.

## Environment Variable Configuration in AWS Elastic Beanstalk
1. Set environment variables for your ASP.NET Core Web API in the AWS Elastic Beanstalk console.
2. Navigate to the Elastic Beanstalk environment, go to "Configuration," and edit the software configuration to add environment variables.
3. Save the changes and, if necessary, restart the environment.

By following these steps, you can automate the deployment of your ASP.NET Core Web API to AWS Elastic Beanstalk using GitHub Actions, ensuring a streamlined and efficient CI/CD process.

## Getting Started
1. **Clone the Repository:**
   ```
    git clone https://github.com/your-username/your-repository.git

2. **Modify GitHub Actions YAML File:**

- Navigate to the repository on your local machine.
- Edit the GitHub Actions YAML file located at .github/workflows/deploy.yml.
- Customize AWS credentials, region, or any other variables based on your AWS setup.

3. **Commit and Push Changes:**

```
    git add .
    git commit -m "Customizing GitHub Actions workflow"
    git push origin main 
```
4. **Check GitHub Actions Workflow:**

- Visit the "Actions" tab on this GitHub repository to monitor the progress of the GitHub Actions workflow triggered by your new push.
- The workflow will execute the specified jobs, building, testing, and deploying the ASP.NET Core Web API to AWS Elastic Beanstalk.
5. **Access Deployed Web API:**

- Once the workflow is completed successfully, access the deployed ASP.NET Core Web API using the URL provided by AWS Elastic Beanstalk.

## Additional Notes

- If you encounter issues, refer to the GitHub Actions workflow logs and AWS Elastic Beanstalk environment logs for debugging.
- Ensure that your AWS credentials are configured securely, and sensitive information is handled with care.
- For any questions or assistance, feel free to open an issue in this repository.

**Thank you! If you find any improvements or have feedback, contributions are welcome.**
