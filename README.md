Project is not finished but core idea how partition key processing should be done is shown in documentation diagram

![image](https://github.com/user-attachments/assets/fdf91525-6cd6-4cb8-8daa-673efdaf55a0)

![image](https://github.com/user-attachments/assets/fa5f0bf5-6f4e-4a37-b72e-ec37126c6a97)

![image](https://github.com/user-attachments/assets/e920a54f-8454-4c8b-b356-ec604c0d0c5e)


This is how we can implement processing where we will be able to process everything parallely but also save ordering between same partition keyed events, because these 
events need to be processed in correct order.

This library is not finished, because full data access and eventing library is reimplemented in better way in GameHub project.
