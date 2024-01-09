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
            }
        }
    }
}
