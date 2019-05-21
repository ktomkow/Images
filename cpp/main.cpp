#include <iostream>
#include <opencv4/opencv2/highgui/highgui.hpp>
#include <opencv4/opencv2/core.hpp>
#include <opencv4/opencv2/opencv.hpp>
#include <opencv4/opencv2/imgproc.hpp>
#include <vector>
#include <sstream>
using namespace std;
using namespace cv;

Mat ResizeImage(Mat image)
{
    Mat resizedImage;
    resize(image, resizedImage, Size(32, 32));  // use specified size
    return resizedImage;
}

Mat ConvertToGray(Mat image)
{
    Mat grayImage;
    cvtColor(image, grayImage, COLOR_BGR2GRAY); // its enouugh for. pgm files
    return grayImage;
}

Mat LoadImage(string path)
{
    Mat image = imread(path);
    if(image.empty())
    {
        cerr << "Could not read image" << endl;
        throw "Could not read image";
    }
    return image;
}

void SaveAsPgm(Mat image, string name)
{
    vector<int> compression_params;
    compression_params.push_back(IMWRITE_PXM_BINARY);
    compression_params.push_back(0);                    // 1 - binary format, 0 - readable format

    string path = "../processedImages/" + name + ".pgm";
    imwrite(path, image, compression_params);
}

void DisplayImage(Mat image)
{    
    namedWindow("Image", WINDOW_AUTOSIZE);
    imshow("Image", image);
    
    waitKey(0);
}

int main(int argc, char** argv)
{
    int firstIndex = 0;
    int lastIndex = strtol(argv[1], NULL, 10);
    stringstream path;
    Mat image;

    for(int i = firstIndex; i <= lastIndex; i++)
    {
        path.str("");
        path << "../images/" << i << ".jpg";

        image = LoadImage(path.str());
        image = ConvertToGray(image);
        image = ResizeImage(image);

        SaveAsPgm(image, to_string(i));
    }

    return 0;
}