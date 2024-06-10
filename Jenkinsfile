pipeline {
    agent any
    stages {
        stage('Clean Workspace') {
            steps {
                echo 'Cleaning Workspace...'
                cleanWs()
            }
        }
        stage('Checkout Code') {
            steps {
                echo 'Checking out code'
                git branch: 'dev', credentialsId: 'github-jenkinsexample-pat-credentials',
                    url: 'https://github.com/SamSchmitty/JenkinsExample.git'
            }
        }
        stage('Restore packages') {
            steps {
                withDotNet(sdk: 'SimpleInputExample_dotnet_8_sdk') {
                    dotnetRestore()
                }
            }
        }
        stage('Build Code') {
            steps {
                withDotNet(sdk: 'SimpleInputExample_dotnet_8_sdk') {
                    dotnetBuild()
                }
            }
        }
        stage('Unit Tests') {
            steps {
                withDotNet(sdk: 'SimpleInputExample_dotnet_8_sdk') {
                    dotnetTest()
                }
            }
        }
    }
    post {
        always {
            recordIssues(
                enabledForFailure: true,
                aggregatingResults: true
            )
        }
    }
}
