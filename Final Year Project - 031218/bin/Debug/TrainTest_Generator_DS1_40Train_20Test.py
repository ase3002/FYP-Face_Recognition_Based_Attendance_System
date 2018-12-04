import osimport shutildef main():    generateTrain_Folder("Dataset 1", 40, 20)    print("Training and Testing Images have been added successfully for Data Set 1!")def generateTrain_Folder(DS_DIR, trainSetNo = 40, testSetNo = 20):    BASE_DIR = os.path.dirname(os.path.abspath(__file__))    img_dir = os.path.join(BASE_DIR, DS_DIR)    original_Data = os.path.join(img_dir, "dataset")    training_data = os.path.join(img_dir, "Training Image")    test_data = os.path.join(img_dir, "Test Image")    trainingset_amount = trainSetNo    test_set_amount = testSetNo    counter = 1    if not os.path.exists(training_data):        os.makedirs(training_data)    if not os.path.exists(test_data):        os.makedirs(test_data)    # print (os.listdir(original_Data))    for iden in os.listdir(original_Data):        print(iden)        img_folders = os.path.join(original_Data, iden)        counter = 1        for root, dirs, files in os.walk(img_folders):            img_counter = len(files)            # print(files)            # print(img_counter)            identity = os.path.basename(os.path.dirname(os.path.join(root, files[0]))).replace(" ", "-").lower()            if (img_counter < trainingset_amount + test_set_amount):                print(                "The identity " + identity + " have too little image to train and test. The minimum image required is " + str(                    trainingset_amount + test_set_amount))            else:                for file in files:                    directory = os.path.join(root, file)                    if file.lower().endswith(('.png', '.jpg', '.jpeg', '.bmp')):                        identityName = os.path.basename(os.path.dirname(directory)).replace(" ", "-").lower()                        if counter <= trainingset_amount:                            training_folder = os.path.join(training_data, identityName)                            if not os.path.exists(training_folder):                                os.makedirs(training_folder)                            shutil.copy(directory, training_folder + "\\" + file)                            counter += 1                        elif counter > trainingset_amount and counter <= trainingset_amount + test_set_amount:                            test_folder = os.path.join(test_data, identityName)                            if not os.path.exists(test_folder):                                os.makedirs(test_folder)                            shutil.copy(directory, test_folder + "\\" + file)                            counter += 1                        elif counter >= trainingset_amount + test_set_amount:                            counter = 1                            print(str(identityName) + " have been sorted successfully")                            breakif __name__ == "__main__":    main()