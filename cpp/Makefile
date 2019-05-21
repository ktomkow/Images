CXX = g++
CXXFLAGS = -Wall -Werror -Wextra -pedantic -std=c++17 -g -fsanitize=address 
LDFLAGS =  -fsanitize=address
LBLIBS = -I /usr/include/opencv4 -L /usr/lib -lopencv_core -lopencv_imgproc -lopencv_highgui -lopencv_imgcodecs

SRC = *.cpp
OBJ = $(SRC:.cc=.o)
EXEC = a.out

all: $(EXEC)

$(EXEC): $(OBJ)
	$(CXX) $(LDFLAGS) -o $@ $(OBJ) $(LBLIBS) -O2

clean:
	rm -rf $(OBJ) $(EXEC)