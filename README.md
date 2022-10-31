# Unity Data Contract Tests

## Results

|                              | Unity 2021.3.11f1  | Unity 2022.1.21f1  |                    |                    |                    |
|------------------------------|--------------------|--------------------|--------------------|--------------------|--------------------|
| Collection Type              | IL2CPP Minimal     | IL2CPP Minimal     | IL2CPP Low         | IL2CPP Medium      | IL2CPP High        |
|                              |                    |                    |                    |                    |                    |
| Array With Object Types      | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: |
| Array With Struct Types      | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: |
| Array With Value Types       | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: |
| Dictionary With Struct Types | :x:                | :x:                | :x:                | :x:                | :x:                |
| Dictionary With Value Types  | :x:                | :x:                | :x:                | :x:                | :x:                |
| Enumerable With Object Types | :white_check_mark: | :white_check_mark: | :white_check_mark: | :x:                | :x:                |
| Enumerable With Struct Types | :x:                | :white_check_mark: | :white_check_mark: | :x:                | :x:                |
| Enumerable With Value Types  | :white_check_mark: | :white_check_mark: | :white_check_mark: | :x:                | :x:                |
| List With Object Types       | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: |
| List With Struct Types       | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: |
| List WIth Value Types        | :x:                | :white_check_mark: | :white_check_mark: | :white_check_mark: | :white_check_mark: |
