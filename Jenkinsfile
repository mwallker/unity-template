pipeline {
    agent any

    environment{
       UNITY_PATH="/Applications/Unity/Hub/Editor/2022.3.11f1/Unity.app/Contents/MacOS/Unity"
       GCS_BUCKET = "gs://your-game-cdn/addressables/Windows"
       ADDRESSABLES_DIR = "ServerData/Windows"
    }

    stages {
        stage('Build Android') {
            steps {
                sh './ci/run_android_build.sh'
            }
        }

        stage('Upload Addressables to GCS') {
            steps {
                withCredentials([file(credentialsId: 'GCP_SERVICE_ACCOUNT_JSON', variable: 'GOOGLE_APPLICATION_CREDENTIALS')]) {
                    sh '''
                        gcloud auth activate-service-account --key-file="$GOOGLE_APPLICATION_CREDENTIALS"
                        gcloud config set project your-gcp-project-id
                        gsutil -m rsync -r "$ADDRESSABLES_DIR" "$GCS_BUCKET"
                    '''
                }
            }
        }
    }
}
