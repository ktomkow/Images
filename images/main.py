from glob import glob
import os

def main():
    os.system("rm -r *.jpg")
    path = "./Norwegia1/*"
    i = 0
    for filepath in glob(path, recursive=True):
        print(filepath)
        os.system("cp {0} ./{1}.jpg".format(filepath, i))
        i = i + 1

    os.system("")


if __name__ == "__main__":
    main()