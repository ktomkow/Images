#include <iostream>
#include <opencv4/opencv2/highgui/highgui.hpp>
#include <opencv4/opencv2/core.hpp>
#include <opencv4/opencv2/opencv.hpp>
#include <opencv4/opencv2/imgproc.hpp>
#include <vector>
using namespace std;
using namespace cv;


int main(int argc, char** argv)
{
    cout << "OpenCV version: " << CV_VERSION << endl;
    cout << "Seems like it works " << endl;
    Mat image;

    Mat sourceImage = imread("fries.jpg");

    if(sourceImage.empty())
    {
        std::cerr << "Could not read image" << endl;
        return 1;
    }

    // Display source image
    // namedWindow("Source", WINDOW_AUTOSIZE);
    // imshow("Source", sourceImage);

    // Convert to grayscale
    Mat grayImage;
    cvtColor(sourceImage, grayImage, COLOR_BGR2GRAY); // its enouugh for. pgm files

    // resize
    // resize(grayImage, grayImage, Size(), 0.1, 0.1); // use proportions
    resize(grayImage, grayImage, Size(1920, 300));  // use specified size

    // save image
    // cvtColor(grayImage, grayImage, COLOR_BGRA2BGR); // for ppm
    vector<int> compression_params;
    compression_params.push_back(IMWRITE_PXM_BINARY);
    compression_params.push_back(0);                    // 1 - binary format, 0 - readable format

    imwrite("grayfries.pgm", grayImage, compression_params);
    // imwrite("grayfries.ppm", grayImage, compression_params); // save ppm file

    // Display gray image

    // namedWindow("Grayscale", WINDOW_AUTOSIZE);
    // imshow("Grayscale", grayImage);
    
    waitKey(0);

    cout << "Closing ..." << endl;
}