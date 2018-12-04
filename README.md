Updates to FYP:

    Integrated both the student data sets and the celebrity data sets into the project. Users are able to conduct face recognition experiments using Eigenfaces by selecting the Data Set from the choose data set combo box before clicking the "Start Test" button to run the experiments. There are a total of six(6) data sets which users can choose from to run the experiments. The Data Sets which users can choose from are as follows:

    (a) Student Data Set 1 (b) Student Data Set 2 (c) Student Data Set 3  (d) Celebrity Data Set 1 (e) Celebrity Data Set 2 (f) Celebrity Data Set 3

How to use:
Select Admin-> Conduct Face Recognition Experiments using Eigenfaces-> Select Dataset from the "Choose Data Set:" combo box-> Click on "Start Test" button to run the experiments

    Integrated a function for users to add all the training images automatically by selecting the folder containing the training images which he or she wants to use for the experiments. The cropped detected faces from the folder containing the training images which the user has selected will be added to the training set.

How to use: Select Admin-> Conduct Face Recognition Experiments using Eigenfaces-> Select Dataset from the "Choose Data Set:" combo box-> Click on "Add training images from folder" button -> Select a folder which contains your training images-> Click "OK"

    Integrated a function for users to split a data set containing images into training sets and testing sets automatically after the user has specified the number of training and testing images which he needs for each identity.

How to use: Select Admin-> Meaningful Data Sets to benchmark face recognition algorithms->In the "Training and Testing Set" generator panel -> Select a Data Set from the combo box -> Choose the number of training and testing images from the combo box -> Click on "Generating Training and Testing Sets" button to generate the training and testing images.

    Integrated a function for users to run face recognition experiments using the LBPH algorithm by selecting the respective datasets from the combo box and also after selecting the confidence values from the combo box. Datasets 1,2,3,4,5 and 6 are used. Data sets 1-5 contain images of celebrities (Leo's data sets) while Data set 6 contains images of students (Wen Jun's data sets).

How to use:
Select Admin-> Meaningful Datasets to benchmark face recognition algorithms-> Select the Data Set from the "Data Set" combo box and the Confidence Value from the "Confidence Value" combo box -> Run the LBPH algorithm

    Integrated a function for users to run face recognition experiments using the KNN algorithm by selecting the respective datasets from the combo box and also after selecting the confidence value from the combo box. Datasets 1,2,3,4,5 and 6 are used. Data sets 1-5 contain images of celebrities (Leo's data sets) while Data set 6 contains images of students (Wen Jun's data sets).

How to use:
Select Admin-> Meaningful Datasets to benchmark face recognition algorithms-> Select the Data Set from the "Data Set" combo box and the Confidence Value from the "Confidence Value" combo box -> Run the KNN algorithm

Work in progress:

Issues were encountered when integrating the Student Data Set (Wen Jun's data sets) into the LBPH and KNN algorithm due to insufficient training images and testing images. This problem is still trying to be resolved.