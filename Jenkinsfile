pipeline {
    agent any
    tools {
        withDotNet(sdk: 'SimpleInputExample_dotnet_8_sdk')
    }
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
                git branch: 'main', credentialsId: 'github-jenkinsexample-pat-credentials',
                    url: 'https://github.com/SamSchmitty/JenkinsExample.git'
            }
        }
        stage('Restore packages') {
            steps {
                dotnetRestore()
            }
        }
        stage('Build Code') {
            steps {
                dotnetBuild()
            }
        }
        stage('Unit Tests') {
            steps {
                dotnetTest()
            }
        }
    }
}
