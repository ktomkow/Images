def main():
    good_lines = []
    originalFile = "cppResults.txt"
    with open(originalFile) as f:
        content = f.readlines()

    i = 0
    for line in content:
        if i == 0 or i == 11:
            good_lines.append(line)
            i = 0
        i = i + 1

    f = open(originalFile,"w")
    for line in good_lines:
        f.write(line)
    f.close()


if __name__ == "__main__":
    main()