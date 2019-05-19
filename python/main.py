import cv2

def main():
    print("Main started")

    startingIndex = 0
    lastIndex = 172

    for i in range(startingIndex, lastIndex + 1):
        path = "../images/{0}.jpg".format(i)
        print(path)
        img = load_image(path)
        img = convert_to_gray(img)
        img = resize_image(img)
        save_as_pgm(img, i)

    print("Main finished")
    

def resize_image(image):
    return cv2.resize(image, (32,32))


def load_image(path):
    return cv2.imread(path, cv2.COLOR_BGR2GRAY)


def convert_to_gray(image):
    return cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)


def save_as_pgm(image, name):
    params = []
    params.append(cv2.IMWRITE_PXM_BINARY)
    params.append(0)
    cv2.imwrite("../processedImages/{0}.pgm".format(name), image, params)


if __name__ == "__main__":
    main()