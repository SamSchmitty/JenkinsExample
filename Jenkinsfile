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
                git branch: 'JenkinsTestBranch', credentialsId: 'github-jenkinsexample-pat-credentials',
                    url: 'https://github.com/SamSchmitty/JenkinsExample.git'
            }
        }
        stage('Restore packages') {
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Build Code') {
            steps {
                sh 'dotnet build'
            }
        }
        stage('Unit Tests'){
            steps {
                sh 'dotnet test'
            }
        }
    }
}
