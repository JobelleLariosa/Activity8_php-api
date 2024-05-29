<?php
header("Content-Type: application/json");

$host = 'localhost';
$db = 'bsit3c_edp';
$user = 'root';
$pass = '';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES => false,
];

$pdo = new PDO($dsn, $user, $pass, $options);

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    // Fetch contents from the 'credential' table
    $stmtCredential = $pdo->query("SELECT idCredential, username, password, name, email, isActive, position FROM credential");
    $credentialData = $stmtCredential->fetchAll();

    // Fetch contents from the 'customer' table
    $stmtCustomer = $pdo->query("SELECT CustomerID, CustomerName, ContactNumber, Location, Payment, Email FROM customers");
    $customerData = $stmtCustomer->fetchAll();

    // Combine data from both tables into a single array
    $responseData = [
        'credential' => $credentialData,
        'customer' => $customerData
    ];

    echo json_encode($responseData);
} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);

    // Check if the input contains data for adding a customer
    if (isset($input['CustomerName']) && isset($input['ContactNumber']) && isset($input['Location']) && isset($input['Payment']) && isset($input['Email'])) {
        // Check for missing required fields for 'customers' table
        $requiredFieldsCustomer = ['CustomerName', 'ContactNumber', 'Location', 'Payment', 'Email'];
        foreach ($requiredFieldsCustomer as $field) {
            if (!isset($input[$field])) {
                echo json_encode(['error' => "Missing required field for customers table: $field"]);
                http_response_code(400); // Bad Request
                exit;
            }
        }

        // Insert data into 'customers' table
        $sql_insert_customer = "INSERT INTO customers (CustomerName, ContactNumber, Location, Payment, Email) VALUES (?, ?, ?, ?, ?)";
        $stmt_insert_customer = $pdo->prepare($sql_insert_customer);

        try {
            $stmt_insert_customer->execute([$input['CustomerName'], $input['ContactNumber'], $input['Location'], $input['Payment'], $input['Email']]);
            echo json_encode(['message' => 'Customer added successfully']);
        } catch (PDOException $e) {
            echo json_encode(['error' => 'Failed to add customer: ' . $e->getMessage()]);
            http_response_code(500); // Internal Server Error
            exit;
        }
    } else {
        // Check for missing required fields for 'credential' table
        $requiredFieldsCredential = ['username', 'password', 'name', 'email', 'isActive', 'position'];
        foreach ($requiredFieldsCredential as $field) {
            if (!isset($input[$field])) {
                echo json_encode(['error' => "Missing required field for credential table: $field"]);
                http_response_code(400); // Bad Request
                exit;
            }
        }

        // Insert data into 'credential' table
        $sql_insert_credential = "INSERT INTO credential (username, password, name, email, isActive, position) VALUES (?, ?, ?, ?, ?, ?)";
        $stmt_insert_credential = $pdo->prepare($sql_insert_credential);

        try {
            $stmt_insert_credential->execute([$input['username'], $input['password'], $input['name'], $input['email'], $input['isActive'], $input['position']]);
            echo json_encode(['message' => 'User added successfully']);
        } catch (PDOException $e) {
            echo json_encode(['error' => 'Failed to add user: ' . $e->getMessage()]);
            http_response_code(500); // Internal Server Error
            exit;
        }
    }
}
?>
