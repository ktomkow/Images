import cv2

def main():
    print("Main started")

    img = cv2.imread("fries.jpg", cv2.COLOR_BGR2GRAY)

    grayImage = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)

    resizedGrayImage = cv2.resize(grayImage,(5,5))

    params = []
    params.append(cv2.IMWRITE_PXM_BINARY)
    params.append(0)
    cv2.imwrite("gray.pgm", resizedGrayImage, params)
    print("Main finished")
    

if __name__ == "__main__":
    main()