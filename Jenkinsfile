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
                sh 'dotnet build'
            }
        }
        stage('Unit Tests') {
            steps {
                sh 'dotnet test'
            }
        }
    }
}
